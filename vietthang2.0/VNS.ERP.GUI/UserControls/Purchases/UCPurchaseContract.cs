using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Purchases;
using VNS.Windows;
using VNS.Common;
using System.Runtime.Remoting.Contexts;
using System.Collections;

namespace VNS.ERP.GUI
{
    public partial class UCPurchaseContract : EditControlBase
    {
        PurchaseContract pc = null;
        private bool _isOverSea = false;
        public bool IsOverSea
        {
            get { return _isOverSea; }
            set
            {
                _isOverSea = value;
                if (!_isOverSea)
                {
                    this.colPriceNT.Visible = false;
                    this.lblCurrency.Visible = false;
                    this.lkUpEdiCurrency.Visible = false;
                    this.colVesselCode.Visible = false;
                }

            }
        }

        public UCPurchaseContract()
        {
            InitializeComponent();
            this.SetTextCode(this.btnEditContactNo);
        }
        /// <summary>
        /// <author>Nguyên</author>
        /// <createDate>17/04/2008</createDate>
        /// <description>Binding Data Method</description>
        /// </summary>
        protected override void BindData()
        {
            pc = (dataSource as PurchaseContract);
            if (this.dataSource != null)
            {
                this.btnEditContactNo.Text = pc.ContractNo;
                this.dateEditContract.DateTime = pc.ContractDate;
                this.lkUpEdiVendorCode.EditValue = pc.VendorCode;
                this.lkUpEdiCurrency.EditValue = pc.CurrencyCode;
                this.dateEditFrom.DateTime = pc.FromDate;
                this.dateEditTo.DateTime = pc.ToDate;
                this.chkEditIsTrans.Checked = pc.IsTransported;
                this.chkEditIsFinished.Checked = pc.IsFinished;
                this.txtDescription.Text = pc.Description;
                if (this.EditMode != FormEditMode.ADD)
                {
                    if (pc.PurchaseTransaction == null)
                        pc.PurchaseTransaction = new PurchaseReportBLL().PurchaseTransaction_SelectByContractNo(pc.ContractNo, pc.VendorCode);
                    if (pc.PurchaseInvoice == null)
                        pc.PurchaseInvoice = new PurchaseReportBLL().PurchaseInvoice_SelectByContractNo(pc.ContractNo, pc.VendorCode);
                }
                if (pc.PurchaseTransaction != null)
                {
                    DataViewManager dvManager = new DataViewManager(pc.PurchaseTransaction);
                    DataView dv = dvManager.CreateDataView(pc.PurchaseTransaction.Tables[0]);
                    this.gridControl1.DataSource = dv;
                }
                if (pc.PurchaseTransaction != null)
                {
                    DataViewManager dvManager = new DataViewManager(pc.PurchaseInvoice);
                    DataView dv = dvManager.CreateDataView(pc.PurchaseInvoice.Tables[0]);
                    this.gridControl2.DataSource = dv;
                } 
                else
                    this.gridControl1.DataSource = null;
                this.gridCtrlDetailContract.DataSource = pc.Detail;
            }
            base.BindData();
        }
        /// <summary>
        /// <author>Nguyên</author>
        /// <createDate>17/04/2008</createDate>
        /// <description>Validate Data Method</description>
        /// </summary>
        protected override int ValidateData()
        {
            if (this.btnEditContactNo.Text == string.Empty)
            {
                this.btnEditContactNo.Focus();
                return -1;
            }
            if (this.lkUpEdiVendorCode.EditValue == null || this.lkUpEdiVendorCode.EditValue.ToString() == string.Empty)
            {
                return -2;
            }
            return 0;
        }
        /// <summary>
        /// <author>Nguyên</author>
        /// <createDate>17/04/2008</createDate>
        /// <description>Assign Data Method</description>
        /// </summary>
        protected override void AssignData()
        {
            if (this.dataSource == null)
            {
                dataSource = new PurchaseContract();
            }

            this.pc.ContractNo = this.btnEditContactNo.EditValue.ToString();
            this.pc.ContractDate = this.dateEditContract.DateTime;
            this.pc.VendorCode = this.lkUpEdiVendorCode.EditValue.ToString();
            this.pc.CurrencyCode = this.lkUpEdiCurrency.EditValue.ToString();
            this.pc.FromDate = this.dateEditFrom.DateTime;
            this.pc.ToDate = this.dateEditTo.DateTime;
            this.pc.IsTransported = this.chkEditIsTrans.Checked;
            this.pc.IsFinished = this.chkEditIsFinished.Checked;
            this.pc.IsOverSea = _isOverSea;
            this.pc.Description = this.txtDescription.Text;
            if (this.EditMode == FormEditMode.EDIT)
            {
                //this.pc.UserCreated = Contexts.CurrentUser.LoginName;
                this.pc.UserUpdated = Contexts.CurrentUser.LoginName;
                this.pc.DateUpdated = DateTime.Now;
            }
            if (this.EditMode == FormEditMode.ADD)
            {
                this.pc.UserCreated = Contexts.CurrentUser.LoginName;
                this.pc.UserUpdated = Contexts.CurrentUser.LoginName;
                this.pc.DateCreated = DateTime.Now;
                this.pc.DateUpdated = DateTime.Now;
            }

            if (this.EditMode != FormEditMode.ADD)
                pc.PurchaseTransaction = new PurchaseReportBLL().PurchaseTransaction_SelectByContractNo(pc.ContractNo, pc.VendorCode);
            if (pc.PurchaseTransaction != null)
                this.gridControl1.DataSource = pc.PurchaseTransaction.Tables[0];
            else
                this.gridControl1.DataSource = null;

            base.AssignData();
        }
        /// <summary>
        /// <author>Nguyên</author>
        /// <createDate>17/04/2008</createDate>
        /// <description>Initial Data Object Method</description>
        /// </summary>
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                ListBase<Vendor> lstVendor = new VendorBLL().GetForPurchase();
                lkUpEdiVendorCode.Properties.DataSource = lstVendor;// new SubjectBLL().GetMaterialVendor();
                lookUpVendorName.Properties.DataSource = new VendorBLL().GetAll();
                ListBase<Currency> ds = new CurrencyBL().GetAll();
                Currency t = new Currency();
                t.CurrencyCode = string.Empty;
                ds.Insert(0, t);
                lkUpEdiCurrency.Properties.DataSource = ds;
                lkUpEdiCurrency.ItemIndex = 0;
                lkUpEdiItemCode.DataSource = new ItemBLL().GetAll();
                this.repLookUpKhonhap.DataSource = new StockBLL().GetAll();
                this.repLookUpStockCode.DataSource = new StockBLL().GetAll();
                this.repLookUpItemCode.DataSource = new ItemBLL().GetAll();

                ListBase<Vessel> lstVessel = new VesselBLL().GetAll();
                lstVessel.Insert(0, new Vessel());
                this.repVesselName.DataSource = lstVessel;
            }
        }
        /// <summary>
        /// <author>Nguyên</author>
        /// <createDate>17/04/2008</createDate>
        /// <description>Refesh Controls Method</description>
        /// </summary>
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.btnEditContactNo.Properties.ReadOnly = false;
                this.lkUpEdiVendorCode.Properties.ReadOnly = false;
                this.lkUpEdiCurrency.Properties.ReadOnly = false;
                this.dateEditContract.Properties.ReadOnly = false;
                this.dateEditFrom.Properties.ReadOnly = false;
                this.dateEditTo.Properties.ReadOnly = false;
                this.chkEditIsTrans.Properties.ReadOnly = false;
                this.chkEditIsFinished.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.lookUpVendorName.Properties.ReadOnly = true;
                this.btnEditContactNo.Focus();

                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            }
            if (this.editMode == FormEditMode.EDIT)
            {
                this.btnEditContactNo.Properties.ReadOnly = false;
                this.lkUpEdiVendorCode.Properties.ReadOnly = false;
                this.lkUpEdiCurrency.Properties.ReadOnly = false;
                this.dateEditContract.Properties.ReadOnly = false;
                this.dateEditFrom.Properties.ReadOnly = false;
                this.dateEditTo.Properties.ReadOnly = false;
                this.chkEditIsTrans.Properties.ReadOnly = false;
                this.chkEditIsFinished.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.lookUpVendorName.Properties.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = true;

                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                this.lkUpEdiVendorCode.Focus();
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                this.btnEditContactNo.Properties.ReadOnly = true;
                this.lkUpEdiVendorCode.Properties.ReadOnly = true;
                this.lkUpEdiCurrency.Properties.ReadOnly = true;
                this.dateEditContract.Properties.ReadOnly = true;
                this.dateEditFrom.Properties.ReadOnly = true;
                this.dateEditTo.Properties.ReadOnly = true;
                this.chkEditIsTrans.Properties.ReadOnly = true;
                this.chkEditIsFinished.Properties.ReadOnly = true;
                this.txtDescription.ReadOnly = true;
                this.lookUpVendorName.Properties.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;

                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

            }
            base.RefreshControl();
        }
        private void chkEditIsFinished_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
            if (e.KeyCode == Keys.Insert && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (this.gridView1.FocusedRowHandle < 0)
                { }
                else
                {
                    System.Type type = (gridView1.DataSource as IList)[0].GetType();
                    object obj = Activator.CreateInstance(type);
                    (gridView1.DataSource as IList).Insert(this.gridView1.FocusedRowHandle, obj);
                }
            }
        }

        private void lkUpEdiVendorCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lkUpEdiVendorCode.EditValue != null)
            {
                this.lookUpVendorName.EditValue = this.lkUpEdiVendorCode.EditValue;
            }
        }

        private void lookUpVendorName_EditValueChanged(object sender, EventArgs e)
        {
            //if (lookUpVendorName.EditValue != null)
            //{
            //    this.lkUpEdiVendorCode.EditValue = this.lookUpVendorName.EditValue;
            //}
        }

    }
}
