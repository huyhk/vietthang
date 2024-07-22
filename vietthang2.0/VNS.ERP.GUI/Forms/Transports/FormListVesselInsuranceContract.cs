using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormListVesselInsuranceContract : FormEditBase
    {
        private VesselInsuranceContractBLL obj = new VesselInsuranceContractBLL();
        private ListBase<VesselInsuranceContract> lstVesselInsuranceContract = new ListBase<VesselInsuranceContract>();
        public FormListVesselInsuranceContract()
        {
            InitializeComponent();
            this.Business = obj;
            if (!this.DesignMode)
            {
                this.repositoryItemLookUpEdit1.DataSource = (new SubjectBLL().GetBaohiem());
            } 
            
        }


        private void LoadData()
        {
            int Year = int.Parse(spinEditYear.EditValue.ToString());
            DateTime fromDate = new DateTime(Year, 1, 1);
            DateTime toDate = new DateTime(Year, 12, 31);
            lstVesselInsuranceContract = obj.GetByDate(fromDate, toDate);
            this.DataSource = lstVesselInsuranceContract;
        }

        public override void AddNewItem()
        {
            FormEditVesselInsuranceContract frm = new FormEditVesselInsuranceContract();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.AddNewItem();
            frm.ShowDialog();

            gridControl1.RefreshDataSource();
            this.RefreshButtons();
            
        }

        public override void EditItem()
        {
            FormEditVesselInsuranceContract frm = new FormEditVesselInsuranceContract();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            frm.ShowDialog();

                
            this.gridView1.FocusedRowHandle = lstVesselInsuranceContract.IndexOf(this.CurrentItem as VesselInsuranceContract);
            this.gridControl1.RefreshDataSource();
        }

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditVesselInsuranceContract frm = new FormEditVesselInsuranceContract();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            this.ShowChildForm(frm);
            
            if ((this.DataSource as ListBase<VesselInsuranceContract>).Count > 0)
                this.CurrentItem = frm.CurrentItem;
            else
                this.currentItem = null;
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
            
        }

        private void FormListVesselInsuranceContract_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

    }
}

