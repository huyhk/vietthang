using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows.Forms;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormListPurchaseContract : FormEditBase
    {
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate = Contexts.WorkingEndDate;
        private PurchaseContractBLL purchaseContractBLL = new PurchaseContractBLL();
        private ListBase<PurchaseContract> lstPurchaseContract = new ListBase<PurchaseContract>();
        
        private bool _isOverSea = false;
        public bool IsOverSea
        {
            get { return _isOverSea; }
            set { _isOverSea = value; }
        }

        public FormListPurchaseContract()
        {
            InitializeComponent();
        }
        public FormListPurchaseContract(string text, bool isoversea)
        {
            InitializeComponent();
            this.Text = text;
            this.IsOverSea = isoversea;
        }

        /// <summary>
        /// Form List Purchase Contract Load method
        /// </summary>
        /// <author>Nguyen</author>
        /// <createDate>18/04/2008</createDate>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormListPurchaseContract_Load(object sender, EventArgs e)
        {
            //ListBase<PurchaseContract> lstContract = (new PurchaseContract()).GetAll();
            if (!this.DesignMode)
            {
                this.Business = new PurchaseContractBLL();
                //this.DataSource = (new PurchaseContractBLL()).GetAll();
                //lstPeriods = new PeriodBLL().GetAll();
                //this.cboPeriodCode.Properties.DataSource = lstPeriods;
                //this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;
                this.ucDatePeriodSelection1.WorkingDate = DateTime.Today;
                this.repLookUpVendorCode.DataSource = new SubjectBLL().GetAll();
                this.repLookUpCurrency.DataSource = new CurrencyBL().GetAll();
                RefreshData();
            }
        }

        /// <summary>
        /// Add New Item method
        /// </summary>
        /// <author>Nguyen</author>
        /// <createDate>18/04/2008</createDate>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void AddNewItem()
        {
            //isOverSea = true;
            FormEditPurchaseContract frmEdiPurContact = new FormEditPurchaseContract(this.Text,IsOverSea);
            SetFormPrivilege(frmEdiPurContact);
            frmEdiPurContact.DataSource = this.DataSource;
            frmEdiPurContact.AddNewItem();
            frmEdiPurContact.ShowDialog();
            if ((this.DataSource as ListBase<PurchaseContract>).Count > 0)
            {
                this.CurrentItem =  frmEdiPurContact.CurrentItem;
                this.gridView1.FocusedRowHandle = lstPurchaseContract.IndexOf(this.CurrentItem as PurchaseContract);
            }
            else
            {
                this.CurrentItem = null;
            }
            this.gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }


        public override void EditItem()
        {
            FormEditPurchaseContract frmEdiPurContact = new FormEditPurchaseContract(this.Text, IsOverSea);
            SetFormPrivilege(frmEdiPurContact);
            frmEdiPurContact.DataSource = this.DataSource;
            frmEdiPurContact.CurrentItem = this.CurrentItem;
            frmEdiPurContact.EditItem();
            frmEdiPurContact.ShowDialog();

            if ((this.DataSource as ListBase<PurchaseContract>).Count > 0)
            {
                this.CurrentItem = frmEdiPurContact.CurrentItem;

                //this.gridView1.FocusedRowHandle = lstPurchaseContract.IndexOf(this.CurrentItem as PurchaseContract);

            }
            else
            {
                this.CurrentItem = null;
            }

            this.gridControl1.RefreshDataSource();

            //this.RefreshButtons(); 
            //base.EditItem();
        }


        private void LoadDSGridCrl()
        {
            if (this.gridView1.RowCount>0)
            {
                FormEditPurchaseContract frm = new FormEditPurchaseContract(this.Text, IsOverSea);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                frm.ShowDialog();
                if ((this.DataSource as ListBase<PurchaseContract>).Count > 0)
                    this.CurrentItem = frm.CurrentItem;
                else
                    this.CurrentItem = null;
                gridControl1.RefreshDataSource();
                this.RefreshButtons();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            LoadDSGridCrl();
        }

        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            startDate = lstPeriods[this.cboPeriodCode.ItemIndex].StartDate;
            endDate = lstPeriods[this.cboPeriodCode.ItemIndex].EndDate;

            lstPurchaseContract = purchaseContractBLL.GetForPeriod(startDate, endDate, IsOverSea);
            this.DataSource = lstPurchaseContract;
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            startDate = this.ucDatePeriodSelection1.StartDate;
            endDate = this.ucDatePeriodSelection1.EndDate;

            lstPurchaseContract = purchaseContractBLL.GetForPeriod(startDate, endDate, IsOverSea);
            this.DataSource = lstPurchaseContract;
        }
        //private void gridControl1_Click(object sender, EventArgs e)
        //{
        //    LoadDSGridCrl();

        //}
    }
}