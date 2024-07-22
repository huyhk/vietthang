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

namespace VNS.ERP.GUI
{
    public partial class FormInstrumentOpening : FormEditBase
    {
        string periodCode = "";
        string startDate = "";
        private PeriodBLL periodBLL = null;
        public FormInstrumentOpening()
        {
            InitializeComponent();
        
        }
        private void FormInstrumentOpening_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                periodBLL = new PeriodBLL();
                Period obj = periodBLL.GetMin();
                this.startDate = obj.StartDate.ToString(VNS.Common.AppConfigs.CONFIG_DATEFORMAT);
                this.periodCode = obj.PeriodCode;
                this.Text += " " + this.startDate;
                lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                this.repLookUpEditItemCode.DataSource = new InstrumentItemBLL().GetAll();
                this.repItemLookUpItemCode.DataSource = repLookUpEditItemCode.DataSource;
                this.repLookUpEditItemCode.EditValueChanged += new EventHandler(repLookUpEditItemCode_EditValueChanged);


                this.repItemTextEditAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
                this.repItemTextEditAmount.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
                this.repItemTextEditQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
                this.repItemTextEditQuantity.EditFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
                this.colAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
                this.colQuantity.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
                try
                {
                    lookUpStockCode.ItemIndex = 0;
                }
                catch
                {
                }
                if(periodBLL.SelectIsClosedTrue(enumModuleID.Accounting.ToString()).Count==0)
                    this.EditMode = FormEditMode.VIEW;
                this.navigatorFrmEditBase.Visible = false;
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
                this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
               
            }
        }
        void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null)
            {
                gridControl1.DataSource = new InstrumentOpeningBLL().GetByPeriodCodeAndStockCode(this.periodCode, lookUpStockCode.EditValue.ToString());
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null)
            {
                gridControl1.DataSource = new InstrumentOpeningBLL().GetByPeriodCodeAndStockCode(this.periodCode, lookUpStockCode.EditValue.ToString());
            }
        }
        void repLookUpEditItemCode_EditValueChanged(object sender, EventArgs e)
        {
            string itemCode = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode").ToString();
            this.gridView1.SetRowCellValue(gridView1.FocusedRowHandle, this.colItemName, itemCode);
        }
        
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
                if (e.KeyCode == Keys.Delete) this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
        }
        public override void RefreshButtons()
        {
            this.btnEdit.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.EditMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.EditMode == FormEditMode.EDIT;
            gridView1.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            lookUpStockCode.Properties.ReadOnly = this.EditMode != FormEditMode.VIEW;
            if (this.EditMode != FormEditMode.VIEW)
            {
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
            {
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
          
        }
        protected override int ValidateData()
        {
            ListBase<InstrumentOpening> lst = gridControl1.DataSource as ListBase<InstrumentOpening>;
            if (lookUpStockCode.EditValue == null) return -1;
            foreach (InstrumentOpening instrOpening in lst)
            {
                foreach (InstrumentOpening instrOpening1 in lst)
                {
                    if (instrOpening1.ItemCode == instrOpening.ItemCode && instrOpening != instrOpening1) return -2;
                }
                if (instrOpening.ItemCode == null || instrOpening.ItemCode == string.Empty) return -3;
            }
            return 0;
        }
        protected override bool SaveData()
        {
           ListBase<InstrumentOpening> lst = gridControl1.DataSource as ListBase<InstrumentOpening>;
           
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            foreach (InstrumentOpening instrOpening in lst)
            {
                instrOpening.PeriodCode = this.periodCode;
                instrOpening.StockCode = lookUpStockCode.EditValue.ToString();
            }
            messageType = ErrorMessageType.INSERT;
            int Error = new InstrumentOpeningBLL().Insert(lst, this.periodCode, lookUpStockCode.EditValue.ToString());
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }

       

    }
}