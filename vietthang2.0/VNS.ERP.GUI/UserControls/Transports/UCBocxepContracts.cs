using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCBocxepContracts : EditControlBase
    {
        public UCBocxepContracts()
        {
            InitializeComponent();
        }
        private Guid contractID;

        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        protected override int ValidateData()
        {
            this.txtContractNo.Text = this.txtContractNo.Text.Trim();
            if (this.txtContractNo.Text== string.Empty)
            {
                this.txtContractNo.Focus();
                return -1;
            }
            if (this.lookUpEditBocxepSubjectCode.EditValue == null || this.lookUpEditBocxepSubjectCode.EditValue.ToString() == string.Empty)
            {
                return -6;
            }
            return base.ValidateData();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                lookUpEditBocxepSubjectCode.Properties.DataSource = new VendorBLL().GetForBocxep();
            }
        }
        protected override void AssignData()
        {
            if (this.dataSource == null)
                dataSource = new BocxepContract();
            (this.dataSource as BocxepContract).ContractDate =txtContractDate.DateTime;
            (this.dataSource as BocxepContract).ContractNo = txtContractNo.Text;
            (this.dataSource as BocxepContract).FromDate=this.txtFromDate.DateTime  ;
            (this.dataSource as BocxepContract).ToDate = this.txtToDate.DateTime;
            (this.dataSource as BocxepContract).Description = this.txtDienGiai.Text;
            (this.dataSource as BocxepContract).BocxepSubjectCode = lookUpEditBocxepSubjectCode.EditValue.ToString();
            //if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            //{
            //    (dataSource as BocxepContract).UserCreated = Contexts.CurrentUser.LoginName;
            //    (dataSource as BocxepContract).DateCreated = DateTime.Now;
            //}
            //(dataSource as BocxepContract).UserUpdated = Contexts.CurrentUser.LoginName;
            //(dataSource as BocxepContract).DateUpdated = DateTime.Now;
             base.AssignData();
       }
       public override void RefreshControl()
        {
            bool viewMode = this.EditMode == FormEditMode.VIEW;
            this.txtContractDate.Properties.ReadOnly = viewMode;
            this.txtContractNo.Properties.ReadOnly = viewMode;
            this.txtDienGiai.Properties.ReadOnly = viewMode;
            this.txtFromDate.Properties.ReadOnly = viewMode;
            this.txtToDate.Properties.ReadOnly = viewMode;
            this.lookUpEditBocxepSubjectCode.Properties.ReadOnly = viewMode;
            //this.gridView1.OptionsBehavior.Editable = true;
            this.btnThem.Enabled = viewMode;
            this.btnAddService.Enabled = viewMode;

            if (this.editMode == FormEditMode.EDIT || this.editMode == FormEditMode.ADD)
            {
                this.btnThem.Enabled = viewMode;

            }
            if (this.DataSource == null)
            {
                txtDienGiai.Text = "";
                txtContractNo.Text = "";
                gridControl1.DataSource = null;
            }
            base.RefreshControl();
        }
        protected override void BindData()
        {
            if (this.dataSource != null)
            {
                this.ContractID = (dataSource as BocxepContract).ContractID;
                this.txtContractNo.Text = (dataSource as BocxepContract).ContractNo;
                this.txtContractDate.DateTime = (dataSource as BocxepContract).ContractDate;
                this.txtToDate.DateTime = (dataSource as BocxepContract).ToDate;
                this.txtFromDate.DateTime = (dataSource as BocxepContract).FromDate;
                this.lookUpEditBocxepSubjectCode.EditValue = (dataSource as BocxepContract).BocxepSubjectCode;
                this.txtDienGiai.Text = (dataSource as BocxepContract).Description;
                this.gridControl1.DataSource = (dataSource as BocxepContract).Detail;

                this.gridControlService.DataSource = (dataSource as BocxepContract).ListBocxepContractService;

            }
            base.BindData();
        }

        public override bool Save()
        {
            bool b = base.Save();
            if (b)
            {
                this.ContractID = (this.DataSource as BocxepContract).ContractID;
            }
            return b;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormEditBocxepContractPrices f = new FormEditBocxepContractPrices(this.contractID);
            f.DataSource = (this.DataSource as BocxepContract).Detail;
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            f.DataSource = gridControl1.DataSource;
            if (cr.Count > 0)
            {
                f.CurrentItem = cr.Current;
            }
            f.AddNewItem();
            f.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditBocxepContractPrices f = new FormEditBocxepContractPrices(this.contractID);
            CurrencyManager cr = this.BindingContext[(this.DataSource as BocxepContract).Detail] as CurrencyManager;
            f.DataSource = (this.DataSource as BocxepContract).Detail;
            if (cr.Count > 0)
            {
                f.CurrentItem = cr.Current;
            }
            (this.FindForm() as FormEditBase).SetFormPrivilege(f);
            f.ShowDialog();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormEditBocxepContractService f = new FormEditBocxepContractService();
            f.Contract = (this.DataSource as BocxepContract);
            f.AddNewItem();
            f.ShowDialog();
        }

        private void gridViewService_DoubleClick(object sender, EventArgs e)
        {
            if (this.EditMode == FormEditMode.VIEW)
            {
                BocxepContractService bcs = this.gridViewService.GetRow(this.gridViewService.FocusedRowHandle) as BocxepContractService;
                if (bcs != null)
                {
                    FormEditBocxepContractService f = new FormEditBocxepContractService();
                    f.Contract = (this.DataSource as BocxepContract);
                    f.CurrentItem = bcs;
                    (this.FindForm() as FormEditBase).SetFormPrivilege(f);
                    f.ShowDialog();
                }
            }
        }

        private void UCBocxepContracts_Load(object sender, EventArgs e)
        {
            bool flag = (this.FindForm() as FormEditBase).AllowAddNew;
            this.btnAddService.Visible = flag;
            this.btnThem.Visible = flag;
        }

        
    }
}
