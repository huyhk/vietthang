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
using VNS.Windows;
using VNS.Common;
using DevExpress.XtraGrid.Views.Grid;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccountStockCostOpening : FormEditBase
    {
        string periodCode = "";
        string startDate = "";
        private PeriodBLL periodBLL = null;
        public FormAccountStockCostOpening()
        {
            InitializeComponent();
         
        }
        private void FormAccountStockCostOpening_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                periodBLL = new PeriodBLL();
                int len1 = Account.MaterialAccount.Length;
                int len2 = Account.ProductAccount.Length;
                this.repLookUpEditItemCode.DataSource = new ItemBLL().GetAll();
                this.repLookUpEditItemName.DataSource = repLookUpEditItemCode.DataSource;
                this.repLookUpEditAccount.DataSource = new AccountBLL().GetObjectDynamic(" left(AccountCode," + len1.ToString() + ") = '" + VNS.ERP.Data.Accounting.Account.MaterialAccount + "' or left(AccountCode, " + len2.ToString() + ") = '" + Account.ProductAccount + "'", "");
                Period obj = periodBLL.GetMin();
                this.startDate = obj.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                this.periodCode = obj.PeriodCode;
                this.Text += " " + this.startDate;
                this.gridControl1.DataSource = new AccountStockCostOpeningBLL().GetByPeriodCode(this.periodCode);
                if (periodBLL.SelectIsClosedTrue(enumModuleID.Accounting.ToString()).Count == 0)
                    this.EditMode = FormEditMode.VIEW;
                this.repTextEditNumDecimaln2.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
                this.colOpeningAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
                this.navigatorFrmEditBase.Visible = false;
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
                this.repLookUpEditItemCode.EditValueChanged += new EventHandler(repLookUpEditItemCode_EditValueChanged);
            }
        }
        void repLookUpEditItemCode_EditValueChanged(object sender, EventArgs e)
        {
            string itemCode = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode").ToString();
            this.gridView1.SetRowCellValue(gridView1.FocusedRowHandle, this.colItemName, itemCode);
            Item i = (repLookUpEditItemCode.DataSource as ListBase<Item>).Search("ItemCode", itemCode);
            if (i != null)
            {
                if (i.ItemType == (Int16)enumItemType.Product)
                {
                    this.gridView1.SetRowCellValue(gridView1.FocusedRowHandle, this.colAccountCode, Account.ProductAccount);
                }
                else
                {
                    this.gridView1.SetRowCellValue(gridView1.FocusedRowHandle, this.colAccountCode, Account.MaterialAccount);
                }
            }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = new AccountStockCostOpeningBLL().GetByPeriodCode(this.periodCode);
        }
       

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
                if (e.KeyCode == System.Windows.Forms.Keys.Delete) 
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
        }
        public override void RefreshButtons()
        {
            this.btnEdit.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.EditMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.EditMode == FormEditMode.EDIT;
            this.gridView1.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
           // base.RefreshButtons();
        }
        protected override int ValidateData()
        {
            ListBase<AccountStockCostOpening> lst = this.gridControl1.DataSource as ListBase<AccountStockCostOpening>;
            foreach (AccountStockCostOpening accStockCostOpening in lst)
            {
                foreach (AccountStockCostOpening accStockCostOpening1 in lst)
                {
                    if (accStockCostOpening1.ItemCode == accStockCostOpening.ItemCode && accStockCostOpening1 != accStockCostOpening) return -1;
                }
                //if (accStockOpening.StockCode == null) return -2;
                if (accStockCostOpening.ItemCode == null) return -2;
                if (accStockCostOpening.AccountCode == null) return -3;
                if (accStockCostOpening.OpeningAmount == 0) return -4;
            }
            return 0;
        }
        protected override bool SaveData()
        {
            ListBase<AccountStockCostOpening> lst = this.gridControl1.DataSource as ListBase<AccountStockCostOpening>;
            foreach (AccountStockCostOpening accStockCostOpening in lst)
            {
                accStockCostOpening.PeriodCode = this.periodCode;
            }
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            messageType = ErrorMessageType.INSERT;
            int Error = new AccountStockCostOpeningBLL().Insert(lst, this.periodCode);
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }
    }
}