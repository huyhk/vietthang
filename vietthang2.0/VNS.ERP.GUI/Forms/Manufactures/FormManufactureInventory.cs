using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.Windows;
using DevExpress.Utils;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormManufactureInventory : FormEditBase
    {
        string txtPeriod,PeriodCode;
        private ListBase<ManufactureInventory> lstManufactureInventory = null;
        private PeriodBLL periodBLL = null;
        public FormManufactureInventory()
        {
            InitializeComponent();
        }
        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStock.EditValue != null)
            {
                this.gridControlManufactureInventory.DataSource = new ManufactureInventoryBLL().GetbyStockCode(lookUpStock.EditValue.ToString(), PeriodCode);
            }
        }
        void LookupItem_EditValueChanged(object sender, EventArgs e)
        {
            string ItemCode = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode").ToString();
            this.gridViewManufactureInventory.SetRowCellValue(this.gridViewManufactureInventory.FocusedRowHandle, this.colItemName, ItemCode);
        }

        private void ManufactureInventories_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                periodBLL = new PeriodBLL();
                lstManufactureInventory = new ListBase<ManufactureInventory>();
                this.colQuantity.DisplayFormat.FormatType = FormatType.Numeric;
                this.colQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
                this.LookupItem.DataSource = new ItemBLL().GetAll();
                this.LookupItemName.DataSource = LookupItem.DataSource;
                this.lookUpStock.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);

                this.LookupItem.EditValueChanged += new EventHandler(LookupItem_EditValueChanged);
                Period obj = periodBLL.GetMin();
                this.txtPeriod = obj.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                PeriodCode = obj.PeriodCode;
                this.Text = this.Text + " " + txtPeriod;
                this.lookUpStock.ItemIndex = 0;
                if (periodBLL.SelectIsClosedTrue(enumModuleID.Manufacture.ToString()).Count == 0)
                    this.EditMode = FormEditMode.VIEW;
                this.navigatorFrmEditBase.Visible = false;
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
            }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            if (lookUpStock.EditValue != null)
                this.gridControlManufactureInventory.DataSource = new ManufactureInventoryBLL().GetbyStockCode(lookUpStock.EditValue.ToString(), PeriodCode);
        }
       
        protected override bool SaveData()
        {
            lstManufactureInventory = (this.gridViewManufactureInventory.DataSource as ListBase<ManufactureInventory>);
            foreach (ManufactureInventory ManufactureInventory in lstManufactureInventory)
            {
                if (ManufactureInventory.StockCode != "") ManufactureInventory.StockCode = this.lookUpStock.EditValue.ToString();
                if (ManufactureInventory.PeriodCode != "") ManufactureInventory.PeriodCode = PeriodCode;
            }
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            messageType = ErrorMessageType.INSERT;
            int Error = new ManufactureInventoryBLL().Insert(lstManufactureInventory, this.lookUpStock.EditValue.ToString(), PeriodCode);
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }
        protected override int ValidateData()
        {
            if (this.lookUpStock.EditValue == null)
                return -1;
            foreach (ManufactureInventory ManufactureInventory in lstManufactureInventory)
            {
                if (ManufactureInventory.ItemCode == null) return -3;
                if (ManufactureInventory.Quantity == 0) return -4;
            }
            return 0;
        }
        public override void RefreshButtons()
        {
            this.btnEdit.Enabled = this.editMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.editMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.editMode == FormEditMode.EDIT;
            gridViewManufactureInventory.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            this.lookUpStock.Properties.ReadOnly = this.editMode == FormEditMode.EDIT;

        }
     
        private void gridViewManufactureInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
                this.gridViewManufactureInventory.DeleteRow(this.gridViewManufactureInventory.FocusedRowHandle);
        }
    }
}