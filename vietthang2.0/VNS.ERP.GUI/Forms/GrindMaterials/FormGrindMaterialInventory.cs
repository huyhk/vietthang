using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Grinds;
using VNS.Common;
using DevExpress.XtraEditors;
using VNS.Windows;
using DevExpress.Utils;

namespace VNS.ERP.GUI
{
    public partial class FormGrindMaterialInventory : FormEditBase
    {
        string txtPeriod, periodCode;
        private ListBase<GrindInventory> lstGrindInventory = null;
        private PeriodBLL periodBLL = null;
        public FormGrindMaterialInventory()
        {
            InitializeComponent();
        }
        
        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStock.EditValue != null)
            {
                this.gridControl.DataSource = new GrindInventoryBLL().GetbyStockCode(lookUpStock.EditValue.ToString(), periodCode);

            }
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
                if (e.KeyCode == Keys.Delete)
                    this.gridView.DeleteRow(this.gridView.FocusedRowHandle);
        }
        protected override int ValidateData()
        {
            if (this.lookUpStock.EditValue == null)
                return -1;
            foreach (GrindInventory grindIn in lstGrindInventory)
            {
                if (grindIn.ItemCode == null) return -3;
                if (grindIn.Quantity == 0) return -4;
            }
            return 0;
        }
        private void FormGrindMaterialInventory_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                periodBLL = new PeriodBLL();
                lstGrindInventory = new ListBase<GrindInventory>();
                this.colQuantity.DisplayFormat.FormatType = FormatType.Numeric;
                this.colQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
                this.LookupItem.EditValueChanged += new EventHandler(LookupItem_EditValueChanged);
                this.LookupItem.DataSource = new ItemBLL().GetAll();
                this.LookupItemName.DataSource = LookupItem.DataSource;
                this.lookUpStock.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                Period obj = periodBLL.GetMin();
                this.txtPeriod = obj.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                periodCode = obj.PeriodCode;
                this.Text = this.Text + " " + txtPeriod;
                this.lookUpStock.ItemIndex = 0;
                if (periodBLL.SelectIsClosedTrue(enumModuleID.Grind.ToString()).Count== 0)
                    this.EditMode = FormEditMode.VIEW;
                this.navigatorFrmEditBase.Visible = false;
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
            }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            if (lookUpStock.EditValue != null)
            this.gridControl.DataSource = new GrindInventoryBLL().GetbyStockCode(lookUpStock.EditValue.ToString(), periodCode);
        }

        void LookupItem_EditValueChanged(object sender, EventArgs e)
        {
            string ItemCode = (sender as LookUpEdit).GetColumnValue("ItemCode").ToString();
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, this.colItemName, ItemCode);
        }
        public override void RefreshButtons()
        {
            
            this.btnEdit.Enabled = this.editMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.editMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.editMode == FormEditMode.EDIT;
            gridView.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            this.lookUpStock.Properties.ReadOnly = this.editMode == FormEditMode.EDIT;
 
        }
        protected override bool SaveData()
        {
            lstGrindInventory = (this.gridView.DataSource as ListBase<GrindInventory>);
            foreach (GrindInventory grindIn in lstGrindInventory)
            {
                if (grindIn.StockCode != "") grindIn.StockCode = this.lookUpStock.EditValue.ToString();
                if (grindIn.PeriodCode != "") grindIn.PeriodCode = periodCode;
            }
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            messageType = ErrorMessageType.INSERT;
            int Error = new GrindInventoryBLL().Insert(lstGrindInventory, this.lookUpStock.EditValue.ToString(),periodCode);
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }
    }
}