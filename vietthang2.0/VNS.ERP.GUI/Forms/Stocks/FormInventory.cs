using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.Windows;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormInventory : FormEditBase
    {
        ListBase<Inventory> lstInventory = new ListBase<Inventory>();
        string txtPeriod,PeriodCode;
        //object lstOlddatasource;
        
        public FormInventory()
        {
            InitializeComponent();
           
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.gridControlInventory.DataSource = new InventoryBLL().GetbyStockCode(lookUpStock.EditValue.ToString(), PeriodCode);
        }
    
        void LookupItem_EditValueChanged(object sender, EventArgs e)
        {
            string ItemName = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode").ToString();
            this.gridViewInventory.SetRowCellValue(gridViewInventory.FocusedRowHandle, this.colItemName, ItemName);
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LookupItem.DataSource = new ItemBLL().GetAll();
                LookupItemName.DataSource = LookupItem.DataSource;
                this.lookUpStock.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                Period obj = new PeriodBLL().GetMin();
                txtPeriod = obj.StartDate.ToString("dd/MM/yyyy");
                PeriodCode = obj.PeriodCode;
                this.Text = this.Text + " " + txtPeriod;
                this.lookUpStock.ItemIndex = 0;

                this.EditMode = FormEditMode.VIEW;
                this.LookupItem.EditValueChanged += new EventHandler(LookupItem_EditValueChanged);
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
                PeriodBLL periodBLL = new PeriodBLL();
                if (periodBLL.SelectIsClosedTrue(enumModuleID.Stock.ToString()).Count > 0)
                {
                    this.btnEdit.Enabled = false;
                }
                this.navigatorFrmEditBase.Visible = false;
            }
        }

        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStock.EditValue != null)
            {
                this.gridControlInventory.DataSource = new InventoryBLL().GetbyStockCode(lookUpStock.EditValue.ToString(), PeriodCode);
                this.LookupStockLocation.DataSource = new StockLocationBLL().GetByStockCode(this.lookUpStock.EditValue.ToString());
                if ((bool)lookUpStock.GetColumnValue("HasLocation")) colStockLocationCode.Visible = true;
                else
                    colStockLocationCode.Visible = false;  
            }

        }
        protected override bool SaveData()
        {
            lstInventory = (this.gridViewInventory.DataSource as ListBase<Inventory>);
            foreach (Inventory ItemInventory in lstInventory)
            {
                if (ItemInventory.StockCode != "") ItemInventory.StockCode = this.lookUpStock.EditValue.ToString();
                if (ItemInventory.PeriodCode != "") ItemInventory.PeriodCode = PeriodCode;
            }
            ErrorMessageType messageType = ErrorMessageType.VALIDATE ;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false ;
            }
            messageType = ErrorMessageType.INSERT;
            int Error = new InventoryBLL().Insert(lstInventory, this.lookUpStock.EditValue.ToString(), PeriodCode);
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }

        private void gridViewInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            if (e.KeyCode == Keys.Delete) 
                this.gridViewInventory.DeleteRow(this.gridViewInventory.FocusedRowHandle);
        }

        protected override int ValidateData()
        {
            if (this.lookUpStock.EditValue == null) return -1;
            foreach (Inventory ItemInventory in lstInventory)
            {
                if (ItemInventory.PeriodCode == null) return -2;
                if (ItemInventory.ItemCode == null) return -3;
                if (ItemInventory.Quantity == 0) return -4;
            }
            return 0;
        }
        public override void RefreshButtons()
        {
            //base.RefreshButtons();
            this.btnEdit.Enabled = this.editMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.editMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.editMode == FormEditMode.EDIT;
            this.gridViewInventory.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            this.lookUpStock.Properties.ReadOnly = this.editMode == FormEditMode.EDIT;
            if (this.EditMode != FormEditMode.VIEW)
            {
                gridViewInventory.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
            {
                gridViewInventory.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }

        
    }
}